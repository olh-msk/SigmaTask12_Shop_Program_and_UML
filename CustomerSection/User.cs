﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    enum UserStatus {New, Registered, VIP, Inanctive, Blocked }
    abstract class User
    {
        public UserStatus UserStatus { get; set; }

        public User()
        {
            this.UserStatus = UserStatus.New;
        }
        //фукція переглянути продукти у магазині
        //буде реалізована пізніше у графічному інтерфейсі до програми
        public void SeeProducts()
        {

        }
    }

    //клас для онлайн користувача, що не зараєструвався у магазині
    class WebUser: User
    {
        public WebUser():base()
        {

        }

        //Метод, щоб зараєструвати покупця
        //буде використовувати GUI для взаємодії і отримання інформації
        //потім виклик перенаправиться у медіатор для обробки
        public void SignUp()
        {
           
        }
    }
}
