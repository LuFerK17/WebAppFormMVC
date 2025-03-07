﻿using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;


namespace WebAppFormMVC.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(500, ErrorMessage = "El mensaje no puede superar los 500 caracteres")]
        public string Mensaje { get; set; }
    }

    public class ContactViewModel
    {
        public ContactMessage NuevoMensaje { get; set; }
        public List<ContactMessage> Mensajes { get; set; } = new List<ContactMessage>();
    }
}

