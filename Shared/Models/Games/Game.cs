using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared.Models.Games
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public GameType GameType { get; set; }
        public string Producent { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string StemUrl { get; set; }
    }
}
