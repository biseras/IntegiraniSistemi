using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Service.Interface
{
    public interface IBackgroundEmailSender
    {
        Task DoWork();
    }
}