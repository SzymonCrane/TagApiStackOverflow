namespace TagApiStackOverflow.Models
{
    public interface ITagsRepository
    {
        Tags GetTag(int Id);
    }
}