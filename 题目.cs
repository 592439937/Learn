
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
// ��dotween�������




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
 �����ȴ�4X4��������ʼ����һ�ؾ�ʣһ������û����䣬�����˵���дϰ�߿��Է������Ͻǡ�


Ȼ���ǹ�����ܣ����Ը������Ͻǵ��ĸ����ӣ��������ּ��ɰ壩��Ȼ���֪ÿ��������治�����ظ�����
���Ÿ����ڶ��У���֪ÿһ�в����ظ�
�ڶ���ͬ��

����������������ÿ�����ʱ������������ֺͳ�ͻ����������ʾ�������ɺ�ɫ�Ӵ֣��������ظ�����ĸ�֪���������������ˡ�

��ɼ���֮��Ϳ��Բ��ø�֪�ˣ�ֻ���Ǹ�������ʾ������

֮����������Ѷȱ��9X9������Խ��Խ��

�������ʼ��ֱ�������ѡ���Ƿ������̳�
 */







