Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.web;
Public Class Registro

Namespace registro.Models
{
    Using System.ComponentModel.DataAnnotations;
    Public Enum TypeContact
    {
       ID,
       Friendof,
       Place,
       Email,
       Birthdate
    }
    End Enum
    Public Class Book
    {
        [Key]
        Public int ID {Get; Set;}
        [Required]
        Public text friendof {Get; Set;}
        Public list place {Get; Set;}  
        [public]
        Public text email {Get; Set;}
        Public time Birthdate {Get; Set;}
    }
}

    End Class
