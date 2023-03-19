# FileTreeBuilder

This class builds the file tree for a given start directory.


## The main method of this class
```csharp
public static TreeNode LoadFileTree(string path)
{
    ...
}
```

The return-value of this function is a `TreeNode` which is the root of the entire file tree.
Input must be the path to the directory u want the tree to start from.

> **NOTE** this function will be made async to run on a different thread.  
> Ohterwise the UI will be locked until this function is finished, which for  
> bigger folders can take a while.

## Helper-functions

These functions support the main function.

### ProcessFiles
```csharp
private static void ProcessFiles(TreeNode root, DirectoryInfo start)
{
    ...
}
```

This function processes the files which arent in any sub-dir of the starting point.  
These will be added to the tree after every dir is processed and added to the root node.

### ProcessDirs
```csharp
private static void ProcessDirs(TreeNode root, DirectoryInfo start)
{
    ...
}
```

This function processes every sub-dir of the starting point, including all the files 
within that sub-dir. The time needed to process every sub-dir depends on how deeply rooted
this directory is.