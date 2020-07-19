﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public partial class tea
    {
        private string _id;
        private string _password;
        private string _name;
        private string _sex;
        private string _position;
        private string _number;
        private string _groupnumber;
        private string _phone;
        private string _email;       
        private string _academy;
        private string _research;
        private string _grade;
        private string _major;
        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        public string position
        {
            set { _position = value; }
            get { return _position; }
        }
        public string number
        {
            set { _number = value; }
            get { return _number; }
        }
        public string groupnumber
        {
            set { _groupnumber = value; }
            get { return _groupnumber; }
        }
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        
        public string academy
        {
            set { _academy = value; }
            get { return _academy; }
        }
        public string research
        {
            set { _research = value; }
            get { return _research; }
        }
        public string grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        public string major
        {
            set { _major = value; }
            get { return _major; }
        }
    }
}
