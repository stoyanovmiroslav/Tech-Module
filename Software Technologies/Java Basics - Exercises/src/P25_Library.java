import sun.util.calendar.BaseCalendar;
import java.util.Date;
import java.util.*;

public class P25_Library {
    private String title;
    private Date date;

    public P25_Library(String title, Date date) {
        this.title = title;
        this.date = date;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }
}
