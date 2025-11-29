using System.Diagnostics;
using Figures;

namespace Lab4;

public class FoodFactory
{
    private Random _random = new();

    public List<Food> FoodList { get; private init; } = [];

    public FoodFactory() { }

    public void CreateFoodAtRandomPlace(Size clipSize, Figure? figure)
    {
        void RandomLocation(Size clipSize, Figure? figure, out int x, out int y)
        {
            RectangleF foodBB;
            do
            {
                x = _random.Next(Food.Size.Width, clipSize.Width - Food.Size.Width);
                y = _random.Next(Food.Size.Height, clipSize.Height - Food.Size.Height);
                foodBB = new(x, y, Food.Size.Width, Food.Size.Height);
            }
            while (figure?.BoundingBox.IntersectsWith(foodBB) ?? false);
        }

        RandomLocation(clipSize, figure, out int x, out int y);
        FoodList.Add(new Apple(x, y));

        RandomLocation(clipSize, figure, out x, out y);

        Food? extraFood = _random.Next(0, 100) switch
        {
            < 20 => new BadApple(x, y),
            >= 20 and < 30 => new SpeedUpPowerUp(x, y),
            >= 30 and < 40 => new ResetPowerUp(x, y),
            _ => null,
        };

        if (extraFood is not null)
        {
            FoodList.Add(extraFood);
        }
    }

    public void Eaten(int index, Size clipSize, Figure? figure)
    {
        if (FoodList[index] is Apple)
        {
            CreateFoodAtRandomPlace(clipSize, figure);
        }

        if (figure is not null)
        {
            FoodList[index].OnEaten(figure);
        }

        FoodList.RemoveAt(index);
    }
}
