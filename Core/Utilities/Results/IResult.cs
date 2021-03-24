using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    //Success Sonuç demek
    //Bool true false şeklinde kullanılarn bir veri tipi

   public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}
