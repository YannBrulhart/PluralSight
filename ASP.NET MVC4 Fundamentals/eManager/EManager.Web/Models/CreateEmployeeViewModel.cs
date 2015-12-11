﻿namespace EManager.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CreateEmployeeViewModel
    {
        #region Public Properties

        [HiddenInput(DisplayValue = false)]
        public int DepartmentId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        public string Name { get; set; }

        #endregion
    }
}