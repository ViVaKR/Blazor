using Iam.Models;

namespace Iam.Components.Pages;

public partial class GameCatalog
{
    // private IEnumerable<Game> games;

    // protected override async Task OnInitializedAsync()
    // {
    //     games = await GameService.GetGames();
    // }

    public GameSummary[] Games { get; set; }

    public GameCatalog()
    {
        Games = [
            new() {
                Id = 1,
                Name = "Street Fighter II",
                Genre = "Fighting",
                Price = 19.99M,
                ReleaseDate = new DateOnly(1992, 7, 15)
            },
            new() {
                Id = 2,
                Name = "Mortal Kombat",
                Genre = "Fighting",
                Price = 59.99M,
                ReleaseDate = new DateOnly(1992, 10, 8)
            },
            new() {
                Id = 3,
                Name = "Super Mario Bros.",
                Genre = "Platformer",
                Price = 59.99M,
                ReleaseDate = new DateOnly(1985, 9, 13)
            },
            new() {
                Id = 4,
                Name = "The Legend of Zelda",
                Genre = "Adventure",
                Price = 59.99M,
                ReleaseDate = new DateOnly(1986, 2, 21)
            },
            new() {
                Id = 5,
                Name = "Doom",
                Genre = "First-Person Shooter",
                Price = 59.99M,
                ReleaseDate = new DateOnly(1993, 12, 10)
            },
            new() {
                Id = 6,
                Name = "Tetris",
                Genre = "Puzzle",
                Price = 59.99M,
                ReleaseDate = new DateOnly(1984, 6, 6)
            },
            new() {
                Id = 7,
                Name = "Pac",
                Genre = "Arcade",
                Price = 59.99M,
                ReleaseDate = new DateOnly(1980, 5, 22)

            },
            new () {
                Id = 8,
                Name = "FIFA 23",
                Genre = "Sports",
                Price = 69.99M,
                ReleaseDate = new DateOnly(2022, 9, 27)
            }
        ];
    }
}

