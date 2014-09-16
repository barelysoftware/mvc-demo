
namespace Mvc.Models
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageBase
    {
        public T CurrentModel { get; set; }
        public LayoutModel Layout { get; set; }
 
        public PageViewModel()
        {
            Layout = new LayoutModel();
            
        } 

        public PageViewModel(T model):this()
        {
            CurrentModel = model;
        } 
    }

    public class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentModel) where T : PageBase
        {
            return new PageViewModel<T>(currentModel);
        }
    }
}