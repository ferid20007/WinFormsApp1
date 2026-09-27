using System.Collections.Generic;

namespace WinFormsApp1
{
    public static class UserStore
    {
        // İstifadəçi adı və şifrəni (Açar, Dəyər) kimi yaddaşda saxlayır
        public static Dictionary<string, string> Istifadechiler = new Dictionary<string, string>();
    }
}