public class Card {

    public Card(string newicon, string newcolor){
        icon = newicon;
        color = newcolor;
    }

    public string icon;
    public string color;
    public string getcolor(){
        return color;

    public string geticon(){
        return icon;
    }
    public void setColor(string newColor){
        color = newColor;
    }
    public abstract string display();
    }
}
