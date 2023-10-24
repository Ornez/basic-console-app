using ConsoleApp1.Foods;

namespace ConsoleApp1;

public interface IStomach
{
    void Digest(Food food);
    bool IsDigestible(Food food);
}
