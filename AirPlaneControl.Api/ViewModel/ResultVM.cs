using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPlaneControl.Api.ViewModel
{

    public class ResultVM : ResultVM<object>
    {
        public ResultVM() : base(null) { }
    }

    public class ResultVM<T> where T : class
    {
        public ResultVM(T value) : this(null, value) { }
        public ResultVM(ValidationResult validationResult) : this(validationResult, null) { }
        public ResultVM(ValidationResult validationResult, T value)
        {
            Messages = validationResult?.Errors.Select(x => x.ErrorMessage).ToList() ?? new List<string>();
            Value = value;
        }

        public T Value { get; set; }
        public IList<string> Messages { get; }
        public string SuccessMessage { get; set; }

        public bool Success { get { return Messages.Count == 0; } }
    }

}
