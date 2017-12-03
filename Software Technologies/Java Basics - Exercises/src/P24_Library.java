public class P24_Library {
    private String author;
    private double price;

    public P24_Library(String author, double price) {
        this.author = author;
        this.price = price;
    }

    public String getAuthor() {
        return author;
    }

    public double getPrice() {
        return price;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public void setPrice(double price) {
        this.price = price;
    }
}
