# FileTreeSearcher
In this class will all the methods be implemented to Search through
the FileTree.
> **NOTE** a later goal is to make this algorithm run on a different thread to not block the UI.

## The main method of this class
```csharp
public static void Search(TreeNode root, string name, TreeView tree)
{
    ...
}
```

This method will be called when a search is initiated. No return value is 
needed because the method modifies the `TreeView` which is passed as a parameter.
In the current setting this method will expend every node on the path to the searched
node.  
Parameters:
- `root` (TreeNode): the root node of the tree which needs to be searched
- `name` (string): the file/folder which is searched after
- `tree` (TreeView): the container

## Helper-methods
```csharp
private static TreeNode SearchRecurse(TreeNode root, string name)
{
    ...
}
```
The recursive functions which computes the correct node, or `null` if no node containing the
searched name in the tree.

```csharp
private static void replaceTree(TreeView tree, TreeNode root)
{
    ...
}
```
Non-used method that updates the tree to only contain the sub-tree starting from the
searched folder/file.