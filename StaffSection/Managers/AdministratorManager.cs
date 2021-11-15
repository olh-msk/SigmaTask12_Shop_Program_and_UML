﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    #region[Administrator Manager]
    interface IOperationAddRemoveAdministrator
    {
        public void AddAdministrator(Administrator admin);
        public void RemoveAdministrator(int adminID);
    }
    //відповідає за керування адміністраторами
    class AdministratorManager : IOperationAddRemoveAdministrator
    {
        private static AdministratorManager instance;

        List<Administrator> administrators;


        private AdministratorManager()
        {
            administrators = new List<Administrator>();
        }

        public static AdministratorManager Instance()
        {
            if(instance == null)
            {
                instance = new AdministratorManager();
            }
            return instance;
        }

        //чи є адміністратор у списку-----
        public bool IfAdministratorExistInList(int adminID)
        {
            bool res = false;
            foreach(Administrator admin in administrators)
            {
                if(admin.AdministratorId == adminID)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        //отримати адміністратора по ID
        public Administrator GetAdministratorById(int adminID)
        {
            if(IfAdministratorExistInList(adminID))
            {
                foreach (Administrator admin in administrators)
                {
                    if (admin.AdministratorId == adminID)
                    {
                        return admin;
                    }
                }
            }
            return null;
        }

        //додати адміністратора
        //якщо його ще нема у списку
        public void AddAdministrator(Administrator admin)
        {
            if(!IfAdministratorExistInList(admin.AdministratorId))
            {
                administrators.Add(admin);
            }
        }
        //видаляє адміна по ід, якщо він є у списку
        public void RemoveAdministrator(int adminID)
        {
            if(IfAdministratorExistInList(adminID))
            {
                for(int i =0; i < administrators.Count;i++)
                {
                    if(administrators[i].AdministratorId == adminID)
                    {
                        administrators.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        //сторити модератора
        //буде взаємодіяти з GUI, щоб отримати дані
        public Administrator CreateNewAdministrator()
        {
            //будуть отримуватись дані для адміністратора і по ним його створять
            //.....
            return new Administrator();
        }

    }
    #endregion
}
