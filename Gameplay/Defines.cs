namespace Monopoly.SuperMarioBros.Gameplay
{
    public enum BoardSpaceType: int 
    {
        GO = 0, 
        Property,
        WarpPipe,
        CoinBlack,
        SuperStar,
        Thwomp,
        JustVisting,
        GoToJail,
        FreeParking
    }
    public enum PowerUpType : int
    {
        RedShell = 0,
        GreenShell,
        Blooper,
        POW,
        Coins
    }

    public enum SuperStarType : int
    {
        Collect = 0,
        Steal,
        Rolling,
        MoveAgain,
        Drop,
        SkipPowerUp,
        BuyUnowned,
    }

    public enum ColourSet : int
    {
        Brown = 0,
        LightBlue,
        Magenta,
        Orange,
        Red,
        Yellow,
        Green,
        DarkBlue
    }
    
    public class Defines
    {

    }
}