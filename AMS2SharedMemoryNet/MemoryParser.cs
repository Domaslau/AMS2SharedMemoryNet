using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using AMS2SharedMemoryNet.Structs;

namespace AMS2SharedMemoryNet
{
    [SupportedOSPlatform("windows")]
    public class MemoryParser
    {
        MemoryMappedFile? mmf;

        private string File {  get; set; }

        public MemoryParser(string file)
        {
            File = file;
            try
            {
                mmf = MemoryMappedFile.OpenExisting(file);
            }
            catch (Exception ex)
            {
                #if DEBUG
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                #endif
                Console.WriteLine("Failed to open file, game is likely not running");
            }
        }

        public AMS2Page GetPage()
        {
            if (mmf!= null)
            {
                AMS2Page page = new();
                do
                {
                    byte[] buffer = new byte[Marshal.SizeOf<AMS2Page>()];

                    MemoryMappedViewStream stream = mmf.CreateViewStream();
                    stream.Read(buffer, 0, buffer.Length);
                    int size = buffer.Length;
                    nint ptr = nint.Zero;
                    
                    try
                    {
                        ptr = Marshal.AllocHGlobal(size);
                        Marshal.Copy(buffer, 0, ptr, size);
                        page = Marshal.PtrToStructure<AMS2Page>(ptr);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                        Marshal.FreeHGlobal(ptr);
                        ptr = nint.Zero;
                    }

                }
                while (page.mSequenceNumber % 2 != 0); //Documentation says that sequence number should be even otherwise page is still being written to
                return page;
            }
            else
            {
                try
                {
                    mmf = MemoryMappedFile.OpenExisting(File);
                    return GetPage();
                }
                catch (Exception ex)
                {
                    #if DEBUG
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    #endif
                    Console.WriteLine("Failed to open file or create a stream, are you trying to access file without game running?");
                    throw new Exception("Failed to open file or create view stream");
                }
            }
        }

        public void Close()
        {
            mmf?.Dispose();
        }
    }
}