using System.Xml.Linq;

namespace TopInterviewQuestions;

// Given an integer array nums, return true if any value appears
// at least twice in the array, and return false if every element is distinct.

public class Node
{
    public int value;
    public Node left;
    public Node right;
}

public class L004_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length == 0 || nums.Length == 1)
        {
            return false;
        }

        Node root = new Node
        {
            value = nums[0]
        };

        for (int i = 1; i < nums.Length; i++)
        {
            var inserted = InsertInTree(root, nums[i]);

            if (!inserted)
            {
                return true;
            }
        }
        return false;
    }

    private bool InsertInTree(Node root, int value)
    {
        if (root.value == value)
        {
            return false;
        }

        if (value < root.value)
        {
            if (root.left == null)
            {
                root.left = new Node { value = value };
                return true;
            }
            else
            {
                return InsertInTree(root.left, value);
            }
        }
        else
        {
            if (root.right == null)
            {
                root.right = new Node { value = value };
                return true;
            }
            else
            {
                return InsertInTree(root.right, value);
            }
        }
    }
}
