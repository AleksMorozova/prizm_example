using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;

namespace Example
{
    interface IPersonView
    {
        event EventHandler Save;
        event EventHandler Load;
        event EventHandler Update;
        event EventHandler Delete;
        event EventHandler ViewDispose;

        void ShowValidationError(string text);
        void SetPerson(Person p);
    }
}
