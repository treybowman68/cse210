public class BasicCard:Card {
    
    public BasicCard(string colorinput, string iconinput) : base (colorprint, iconinput){
        _icon = iconinput;
        _color = colorinput;
    }
    public override string display(){
        return "["+_icon+"] - "+_color;
    }
}