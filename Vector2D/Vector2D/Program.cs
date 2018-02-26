/*
 * Represents (x, y) vector.
 *
 */
using System.Collections.Generic;

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
     * Constructor.
     * 
     */
    public Vector2D(int x = 0, int y = 0)
    {
        this.X = x;
        this.Y = y;
    }

    public int X
    {
        get;
        set;
    }

    public int Y
    {
        get;
        set;
    }
    /*
     * Adds two vectors together.
     */
    public static Vector2D operator +(Vector2D v,Vector2D u)
    {
        var x = u.x + v.x;
        var y = u.y + v.y;

        return new Vector2D(x, y);
    }

    /*
     * Multiplies vector with a constant.
     */
    public static Vector2D operator *(int factor,Vector2D v)
    {
        var x = v.x * factor;
        var y = v.y * factor;

        return new Vector2D(x, y);
    }

    override
    public string ToString()
    {
        return string.Format("(%d, %d)", x, y);
    }

    override
    public bool Equals(object o)
    {
        if (o is Vector2D)
        {
            return Equals(o);
        }
        else
        {
            return false;
        }
    }

    public bool Equals(Vector2D v)
    {
        return v != null && this.x == v.x && this.y == v.y;
    }

    override
    public int GetHashCode()
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
    public static IEnumerable<Vector2D> Directions()
    {
        List<Vector2D> result = new List<Vector2D>();

        for (var dx = -1; dx <= 1; ++dx)
        {
            for (var dy = -1; dy <= 1; ++dy)
            {
                if (dx != 0 || dy != 0)
                {
                    
                    result.Add(new Vector2D(dx, dy));
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
    public IEnumerable<Vector2D> Around()
    {
       var result = new List<Vector2D>();

        foreach (var direction in Directions())
        {
            result.Add(this + direction);
        }

        return result;
    }
}