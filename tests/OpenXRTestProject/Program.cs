using OpenTK.Graphics;
using OpenTK.Graphics.OpenXR;

namespace OpenXRTestProject
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            XRLoader.Init();

            XrApplicationInfo appInfo = new XrApplicationInfo();

            XrInstanceCreateInfo instanceCreate = new XrInstanceCreateInfo();
            instanceCreate.applicationInfo = appInfo;
            instanceCreate.createFlags = 0;
            instanceCreate.enabledApiLayerCount = 0;
            instanceCreate.enabledApiLayerNames = null;
            instanceCreate.enabledExtensionCount = 0;
            instanceCreate.enabledExtensionNames = null;

            XrInstance instance;
            XrResult result = Xr.CreateInstance(&instanceCreate, &instance);

            ;
        }
    }
}
