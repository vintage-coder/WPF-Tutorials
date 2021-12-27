﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Common_Services
{
    public class ModelDataAnnotationCheck : IModelDataAnnotationCheck
    {
        public ModelDataAnnotationCheck()
        {

        }
        public void ValidateModelDataAnnotations<TDomainModel>(TDomainModel domainModel)
        {
            ICollection<ValidationResult> validationResultList = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(domainModel, null, null);

            StringBuilder stringBuilder = new StringBuilder();

            if (!Validator.TryValidateObject(domainModel, validationContext, validationResultList, validateAllProperties: true))
            {
                foreach (ValidationResult validationResult in validationResultList)
                {
                    stringBuilder.Append(validationResult.ErrorMessage)
                                 .AppendLine();
                }
            }
            if (validationResultList.Count > 0)
            {
                throw new ArgumentException(stringBuilder.ToString());
            }
        }
    }
}
