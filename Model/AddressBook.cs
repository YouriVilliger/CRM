using System.Collections.Generic;
using System;

namespace CRM
{
    public class AddressBook
    {
        #region private attributes
        private List<Contact> _contacts = new List<Contact>();
        #endregion private attibutes

        #region public methods
        public void AddContacts(List<Contact> ListToAdd)
        {

            foreach (Contact ContactToAdd in ListToAdd)
            {
                if (!DoesExist(ContactToAdd)){
                    _contacts.Add(ContactToAdd);
                }
                else
                {
                    throw new ContactAlreadyExist();
                }
                
            }
        }

        public bool DoesExist(Contact contactToCheck)
        {
           return _contacts.Contains(contactToCheck);
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }

        public void Remove(Contact contact)
        {
            if (DoesExist(contact))
            {
                _contacts.Remove(contact);
            }
            else
            {
                throw new ContactNotExist();
            }
        }

        public class ContactAlreadyExist : Exception { }

        public class ContactNotExist : Exception { }

        #endregion public methods
    }
}
