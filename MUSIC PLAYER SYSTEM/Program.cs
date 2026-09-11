//MENYU

//0 - Player haqqında məlumat almaq üçün
//1 - Play
//2 - Pause
//3 - Səsi artırmaq
//4 - Səsi azaltmaq
//5 - Mahnını dəyişmək
//6 - Proqramdan çıxmaq

//---
using MUSIC_PLAYER_SYSTEM;
MusicPlayer player = new MusicPlayer("brand", "model", 99, "almaarmud", true, 85);
while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
        player.ShowInfo();
    if (x == 1)
        player.Play();
    if (x == 2)
        player.Pause();
    if (x == 3)
        player.IncreaseVolume();
    if (x == 4)
        player.DecreaseVolume();
    if (x == 5)
    {
        Console.WriteLine("istediyiniz mahnini secin");
        string s = Console.ReadLine();
        player.ChangeSong(s);
    }
    if (x == 6)
        break;
}