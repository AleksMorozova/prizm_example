using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    interface IPersonView
    {
        event EventHandler Save;
        event EventHandler Load;
        event EventHandler ViewDispose;

        void ShowValidationError(string text);
        void SetPerson(Person p);
    }
}
