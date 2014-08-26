using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;

namespace Example
{
    class PersonPresenter
    {
        private IPersonView view;
        private Person person;
        private IPersonRepository personRepo;

        /// <summary>
        /// VIEW AND REPOSITORY SHOULD BE MOCKED IN UNIT TESTS
        /// </summary>
        public PersonPresenter(IPersonView view, IPersonRepository personRepo)
        {
            this.view = view;
            this.personRepo = personRepo;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            view.Save += view_Save;
            view.Delete+=view_Delete;
            view.Load += view_Load;
            view.Update+=view_Update;
            view.ViewDispose += view_ViewDispose;
        }

        void view_ViewDispose(object sender, EventArgs e)
        {
            UnsubscrubeFromEvents();
            view = null;
        }

        private void view_Load(object sender, EventArgs e)
        {
            person = personRepo.GetPerson();
            view.SetPerson(person);
        }

        private void view_Save(object sender, EventArgs e)
        {
            string error = ValidatePerson();

            if (String.IsNullOrEmpty(error))
            {
                personRepo.SavePerson(person);
            }
            else
            {
                view.ShowValidationError(error);
            }
        }
        private void view_Delete(object sender, EventArgs e)
        {
            string error = ValidatePerson();

            if (String.IsNullOrEmpty(error))
            {
                personRepo.DeletePerson(person);
            }
            else
            {
                view.ShowValidationError(error);
            }
        }
        private void view_Update(object sender, EventArgs e)
        {
            string error = ValidatePerson();

            if (String.IsNullOrEmpty(error))
            {
                personRepo.UpdatePerson(person);
            }
            else
            {
                view.ShowValidationError(error);
            }
        }

        public string ValidatePerson()
        {
            if (String.IsNullOrEmpty(person.FirstName))
            {
                return "First Name Is Required";
            }
            if (String.IsNullOrEmpty(person.LastName))
            {
                return "Last Name Is Required";
            }
            return string.Empty;
        }

        private void UnsubscrubeFromEvents()
        {
            view.Save -= view_Save;
            view.Load -= view_Load;
            view.Update -= view_Update;
            view.Delete -= view_Delete;
            view.ViewDispose -= view_ViewDispose;
        }
    }
}
