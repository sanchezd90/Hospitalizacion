using System;
namespace HospiEnCasa.App.Dominio.Entidades
{

    public class Person
    {
        public int Id {get;set;}

        public string FirstName {get;set;}

        public string LastName {get;set;}

        public string Document {get;set;}

        public DocumentType DocumentT {get;set;}

        public string Phone {get;set;}

        public Gender Gender {get;set;}
        
    }
}