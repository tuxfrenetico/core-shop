using System.ComponentModel.DataAnnotations;

namespace CoreShop.ViewModel.Validation
{
  public class RequiredField : RequiredAttribute
  {
    public RequiredField(string fieldName)
    {
      var self = this;
      ErrorMessage = $"O campo '{fieldName}' é requerido.";
    }
  }
}