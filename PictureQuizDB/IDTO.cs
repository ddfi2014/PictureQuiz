using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureQuizDB
{
    public interface IDTO
    {
        void loadRows();
        void updateRows();
        void insertRows();
        void deleteRows();
    }
}
