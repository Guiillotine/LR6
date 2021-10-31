using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Warehouse
    {
        public void AddKorm(Food& spisKorm);
        public Warehouse operator +(const Warehouse& other)
    {
        Warehouse temp;
        for (int i = 0; i< this->kolVo; i++) { temp.KormSklad[i] = this->KormSklad[i]; temp.kolVo++;}
        for (int i = 0; i<other.kolVo; i++) if (temp.kolVo< 100) { temp.KormSklad[i + this->kolVo] = other.KormSklad[i]; temp.kolVo++;}
        return (temp);
    }
    public Warehouse increm()
    {
    Warehouse temp;
    temp.kolVo = this->kolVo;
    for (int i = 0; i < this->kolVo; i++) temp.KormSklad[i] = this->KormSklad[i];

    this->KormSklad[kolVo] = "Корм " + to_string(kolVo + 1); this->kolVo++;
    return (temp);
    }
    public void print()
    {
    for (int i = 0; i < kolVo; i++) cout << "\n " << KormSklad[i];
    }
    private int kolVo = 0;
    private string KormSklad[100]{};
};
}
