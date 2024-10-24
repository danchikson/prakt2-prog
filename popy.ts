/**
 * Definition for a binary tree node.
 */
class TreeNode {
    val: number;
    left: TreeNode | null;
    right: TreeNode | null;

    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
        this.val = (val === undefined ? 0 : val);
        this.left = (left === undefined ? null : left);
        this.right = (right === undefined ? null : right);
    }
}

/**
 * Determines if a binary tree is symmetric (i.e., a mirror image of itself).
 * Recursive approach.
 * 
 * @param root - The root node of the binary tree to check for symmetry.
 * @returns `true` if the binary tree is symmetric, `false` otherwise.
 */
function isSymmetric(root: TreeNode | null): boolean {
    if (!root) return true; // An empty tree is symmetric

    function isMirror(t1: TreeNode | null, t2: TreeNode | null): boolean {
        // Both nodes are null, symmetric
        if (!t1 && !t2) return true;
        // One of the nodes is null, not symmetric
        if (!t1 || !t2) return false;
        // Check values and recursively check subtrees
        return (t1.val === t2.val) && 
               isMirror(t1.left, t2.right) && 
               isMirror(t1.right, t2.left);
    }

    return isMirror(root.left, root.right);
}

/**
 * Alternative iterative approach using queue.
 * Determines if a binary tree is symmetric using breadth-first traversal.
 * 
 * @param root - The root node of the binary tree to check for symmetry.
 * @returns `true` if the binary tree is symmetric, `false` otherwise.
 */
function isSymmetricIterative(root: TreeNode | null): boolean {
    if (!root) return true;

    const queue: (TreeNode | null)[] = [root.left, root.right];

    while (queue.length > 0) {
        const t1 = queue.shift();
        const t2 = queue.shift();

        if (!t1 && !t2) continue;
        if (!t1 || !t2 || t1.val !== t2.val) return false;

        queue.push(t1.left);
        queue.push(t2.right);
        queue.push(t1.right);
        queue.push(t2.left);
    }

    return true;
}

// Example Usage
const root1 = new TreeNode(3, 
    new TreeNode(6, new TreeNode(7), new TreeNode(4)), 
    new TreeNode(6, new TreeNode(4), new TreeNode(7))
);
console.log(isSymmetric(root1)); // Output: true
console.log(isSymmetricIterative(root1)); // Output: true

const root2 = new TreeNode(3, 
    new TreeNode(2, null, new TreeNode(4)), 
    new TreeNode(2, new TreeNode(4), null)
);
console.log(isSymmetric(root2)); // Output: false
console.log(isSymmetricIterative(root2)); // Output: false