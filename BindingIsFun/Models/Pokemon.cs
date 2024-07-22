using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingIsFun.Models;

 class Pokemon:ObservableObject
{
    private int id;
    private string? name;
    private string? type;
    private int hitPoints;
    private string? location;
    private string? imageUrl;
    public int Id { get=>id; set { id = value; OnPropertyChanged(); } }
    public string? Name { get=>name; set { name = value; OnPropertyChanged(); } }
    public string? Type { get=>type; set { type = value; OnPropertyChanged(); } }
    public int Hitpoints { get=>hitPoints; set { hitPoints = value; OnPropertyChanged(); } }
    public string? Location { get=>location; set { location = value; OnPropertyChanged(); } }
    public string? ImageUrl { get=>imageUrl; set { imageUrl = value;OnPropertyChanged(); } }

    

    
}

