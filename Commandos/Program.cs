
using System;
using System.Security.Cryptography;
using Commandos.Models;

namespace Commandos;


class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.initGame();
    }

}