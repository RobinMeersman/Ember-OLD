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

>
> **NOTE** this function will be made async to run on a different thread.  
> Ohterwise the UI will be locked until this function is finished, which for  
> bigger folders can take a while.
> 