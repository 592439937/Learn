
//1,1

private async async move(GameObject gameObject,Vector3 begin,Vector3 end,float time,bool pingpong)
{
    gameObject.transform = begin;
    transform.DOMove(end, time);
    await Task.Delay(time);
    if (pingpong)
    {
        move(gameObject, end, begin, time, pingpong);
    }
}

//1,2
// 用dotween插件控制




// 2
private void cut(int [,]a,int beginRow,int RowCount,int beginColumn,int columnCount,int targetBeginRow,int targetBeginColumn)
{
    int[,] temp = new int[50, 100];
    for(int i=beginRow;i<beginRow+RowCount;i++)
    {
        for(int j = beginColumn; j < beginColumn + columnCount; j++)
        {
            temp[i - beginRow][j - beginColumn] = a[i][j];
        }
    }
    for (int i = targetBeginRow; i < beginRow + RowCount; i++)
    {
        for (int j = targetBeginColumn; j < beginColumn + columnCount; j++)
        {
            a[i][j]=temp[i - targetBeginRow][j - targetBeginColumn]
        }
    }
}




//3
private bool devide(string s ,string[] wordSet)
{
    int len = s.length();
    bool[] a = new bool[len];
    a[0] = true;
    for(int i=0;i<len;i++)
    {
        for(int j=0;j<i;i++)
        {
            if (a[i]) break;
            if (a[j])
            {
                for(int k=0;i<wordSet.Count;i++)
                {
                    if (wordSet[k] == s.substring(j, i))
                    {
                        a[i] = true;
                    }
                }
            }
        }
    }
    return a[len - 1];
}

//4
/*
 * 
 可以先从4X4的数独开始，第一关就剩一个数字没有填充，根据人的书写习惯可以放在左上角。


然后是规则介绍，可以高亮右上角的四个格子（其他部分加蒙板），然后告知每个大框下面不能有重复数字
接着高亮第二行，告知每一行不能重复
第二列同理，

接着是隐形引导，每次填错时会给填充错误数字和冲突数字特殊显示（例如标成红色加粗），可以重复上面的告知操作，高亮就算了。

完成几关之后就可以不用告知了，只有那个特殊显示的提醒

之后就是增加难度变成9X9，数字越来越少

可以在最开始就直接让玩家选择是否跳过教程
 */







