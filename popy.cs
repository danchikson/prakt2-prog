using System;  // Директивы using должны быть первыми

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right) 
    {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;

        return (left.val == right.val) && 
               IsMirror(left.left, right.right) && 
               IsMirror(left.right, right.left);
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        // Test Case 1: [1,4,4,5,6,6,5]
        TreeNode root1 = new TreeNode(1);
        root1.left = new TreeNode(4);
        root1.right = new TreeNode(4);
        root1.left.left = new TreeNode(5);
        root1.left.right = new TreeNode(6);
        root1.right.left = new TreeNode(6);
        root1.right.right = new TreeNode(5);

        Console.WriteLine($"Test Case 1 Result: {solution.IsSymmetric(root1)}"); // Expected: True
        
        // Test Case 2: [1,3,3,null,4,null,4]
        TreeNode root2 = new TreeNode(1);
        root2.left = new TreeNode(3);
        root2.right = new TreeNode(3);
        root2.left.right = new TreeNode(4);
        root2.right.right = new TreeNode(4);

        Console.WriteLine($"Test Case 2 Result: {solution.IsSymmetric(root2)}"); // Expected: False
    }
}
using System;

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    
    private bool IsMirror(TreeNode left, TreeNode right) 
    {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        
        return (left.val == right.val) && 
               IsMirror(left.left, right.right) && 
               IsMirror(left.right, right.left);
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        // Test Case 1: [1,4,4,5,6,6,5]
        TreeNode root1 = new TreeNode(1);
        root1.left = new TreeNode(4);
        root1.right = new TreeNode(4);
        root1.left.left = new TreeNode(5);
        root1.left.right = new TreeNode(6);
        root1.right.left = new TreeNode(6);
        root1.right.right = new TreeNode(5);
        
        Console.WriteLine($"Test Case 1 Result: {solution.IsSymmetric(root1)}");
        
        // Test Case 2: [1,3,3,null,4,null,4]
        TreeNode root2 = new TreeNode(1);
        root2.left = new TreeNode(3);
        root2.right = new TreeNode(3);
        root2.left.right = new TreeNode(4);
        root2.right.right = new TreeNode(4);
        
        Console.WriteLine($"Test Case 2 Result: {solution.IsSymmetric(root2)}");
    }
}using System;

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    
    private bool IsMirror(TreeNode left, TreeNode right) 
    {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        
        return (left.val == right.val) && 
               IsMirror(left.left, right.right) && 
               IsMirror(left.right, right.left);
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        // Test Case 1: [1,4,4,5,6,6,5]
        TreeNode root1 = new TreeNode(1);
        root1.left = new TreeNode(4);
        root1.right = new TreeNode(4);
        root1.left.left = new TreeNode(5);
        root1.left.right = new TreeNode(6);
        root1.right.left = new TreeNode(6);
        root1.right.right = new TreeNode(5);
        
        Console.WriteLine($"Test Case 1 Result: {solution.IsSymmetric(root1)}");
        
        // Test Case 2: [1,3,3,null,4,null,4]
        TreeNode root2 = new TreeNode(1);
        root2.left = new TreeNode(3);
        root2.right = new TreeNode(3);
        root2.left.right = new TreeNode(4);
        root2.right.right = new TreeNode(4);
        
        Console.WriteLine($"Test Case 2 Result: {solution.IsSymmetric(root2)}");
    }
}