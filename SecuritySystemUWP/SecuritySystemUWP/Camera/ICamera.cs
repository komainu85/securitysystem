using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SecuritySystemUWP
{
    public interface ICamera : IDisposable
    {
        bool IsEnabled
        {
            get; set;
        }

        Task Initialize();

        Task TriggerCapture();
    }
}
