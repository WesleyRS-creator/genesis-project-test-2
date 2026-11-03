namespace TestRepositotyV9.Utils;

public class PagedResponse<T>
{
  public List<T> Content { get; set; }
  public PageInfo Page { get; set; }
}
