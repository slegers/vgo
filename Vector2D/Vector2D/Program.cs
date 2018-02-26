package dotnet.exercise1;

import java.util.ArrayList;

/*
 * Represents (x, y) vector.
 *
 */
public class Vector2D
{
    /*
     * X-coordinate
     */
    private int x;

    /*
     * Y-coordinate
     */
    private int y;

    /*
     * Default constructor
     */
    public Vector2D()
    {
        this(0, 0);
    }

    /*
     * Constructor.
     * 
     */
    public Vector2D(int x, int y)
    {
        setX(x);
        setY(y);
    }

    public int getX()
    {
        return x;
    }

    public int getY()
    {
        return y;
    }

    public void setX(int x)
    {
        this.x = x;
    }

    public void setY(int y)
    {
        this.y = y;
    }

    /*
     * Adds two vectors together.
     */
    public Vector2D add(Vector2D v)
    {
        int x = this.x + v.x;
        int y = this.y + v.y;

        return new Vector2D(x, y);
    }

    /*
     * Multiplies vector with a constant.
     */
    public Vector2D mul(int factor)
    {
        int x = this.x * factor;
        int y = this.y * factor;

        return new Vector2D(x, y);
    }

    @Override
    public String toString()
    {
        return String.format("(%d, %d)", x, y);
    }

    @Override
    public boolean equals(Object object)
    {
        if (object instanceof Vector2D )
        {
            return equals((Vector2D)object);
        }
        else
        {
            return false;
        }
    }

    public boolean equals(Vector2D v)
    {
        return v != null && this.x == v.x && this.y == v.y;
    }

    @Override
    public int hashCode()
    {
        return x ^ y;
    }

    /*
     * Returns a list of directions. Directions
     * are vectors representing a single step
     * in a direction (N, NE, E, SE, S, SW, W, NW),
     * i.e. (0, 1), (1, 1), (1, 0), etc. respectively.
     *
     */
    public static Iterable<Vector2D> directions()
    {
        ArrayList<Vector2D> result = new ArrayList<>();

        for (int dx = -1; dx <= 1; ++dx)
        {
            for (int dy = -1; dy <= 1; ++dy)
            {
                if (dx != 0 || dy != 0)
                {
                    result.add(new Vector2D(dx, dy));
                }
            }
        }

        return result;
    }

    /*
     * Returns all neighboring vectors, i.e. vectors
     * one step away in all directions.
     * E.g. (x, y) has neighbors (x + 1, y), (x + 1, y + 1), (x, y + 1), etc. 
     */
    public Iterable<Vector2D> around()
    {
        ArrayList<Vector2D> result = new ArrayList<>();

        for (Vector2D direction : directions())
        {
            result.add(this.add(direction));
        }

        return result;
    }
}