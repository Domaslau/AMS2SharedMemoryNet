using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using AMS2SharedMemoryNet.Structs;

namespace AMS2SharedMemoryNet
{
    [SupportedOSPlatform("windows")]
    public class MemoryParser
    {
        MemoryMappedFile mmf;
        MemoryMappedViewStream stream;
        private bool Closed { get; set; } = false;

        public MemoryParser(string file)
        {
            mmf = MemoryMappedFile.OpenExisting(file);
            stream = mmf.CreateViewStream();
        }

        public AMS2Page GetPage()
        {

        Again:
            if (!Closed)
            {
                byte[] buffer = new byte[Marshal.SizeOf<AMS2Page>()];
                stream.Read(buffer, 0, buffer.Length);
                int size = buffer.Length;
                nint ptr = nint.Zero;
                AMS2Page page = new();
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
                    Marshal.FreeHGlobal(ptr);
                    ptr = nint.Zero;
                }

                if (page.mSequenceNumber % 2 != 0) goto Again;
                return page;
            }
            else
            {
                return new AMS2Page();
            }
        }

        public void Close()
        {
            stream.Close();
            stream.Dispose();
            mmf.Dispose();
            Closed = true;
        }
    }
}