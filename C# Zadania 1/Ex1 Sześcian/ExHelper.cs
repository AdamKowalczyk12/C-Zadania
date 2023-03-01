namespace Ex1
{
    public static class ExHelper
    {
        public static bool CheckFigures(params Szescian[] figures)
        {

            var beforeElement = figures[0];

            for (int i = 1; i < figures.Length; i++)
            {
                if(beforeElement.Krawedz > figures[i].Krawedz)
                {
                    return false;
                }

                beforeElement = figures[i];
            }


            return true;
        }
    }
}
