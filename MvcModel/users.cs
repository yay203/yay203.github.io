using System;
using System.ComponentModel.DataAnnotations;

namespace MvcModel
{
    public class usersData
    {
        private string m_Id;
        private string m_userid;
        private string m_userpwrd;
        private string m_username;
        private string m_usertype;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }

        [Required(ErrorMessage = "This item cannot be empty!")]
        public string userid
        {
            get { return this.m_userid; }
            set { this.m_userid = value; }
        }

        [Required(ErrorMessage = "This item cannot be empty!")]
        public string userpwrd
        {
            get { return this.m_userpwrd; }
            set { this.m_userpwrd = value; }
        }

        [Required(ErrorMessage = "This item cannot be empty!")]
        public string username
        {
            get { return this.m_username; }
            set { this.m_username = value; }
        }

        [DisplayFormat(ConvertEmptyStringToNull = false)]

        public string usertype
        {
            get { return this.m_usertype; }
            set { this.m_usertype = value; }
        }
    }

}