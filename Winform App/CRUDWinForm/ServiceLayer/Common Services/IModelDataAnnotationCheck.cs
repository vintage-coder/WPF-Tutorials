namespace ServiceLayer.Common_Services
{
    public interface IModelDataAnnotationCheck
    {
        void ValidateModelDataAnnotations<TDomainModel>(TDomainModel domainModel);
    }
}