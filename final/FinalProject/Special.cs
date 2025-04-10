public class Special: Card {
    
     public Special(string colorinput, string iconinput) : base (colorprint, iconinput){
        _icon = iconinput;
        _color = colorinput;
        _ability = "none";
    }
    public override string display(){
        return "["+_icon+"] - "+_color;
    }
    public string getAbility(){
        return _ability;

    }
    public void setAbility(string newAbility){
        _ability = newAbility;
    }
}