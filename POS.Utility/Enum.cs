namespace POS.Utility
{
    public class Enum
    {
        public enum StockGroup : int
        {
            未分類群組 = 0,
            倉庫群組1 = 1,
            倉庫群組2 = 2,
            倉庫群組3 = 3,
            倉庫群組4 = 4,
            倉庫群組5 = 5,
            倉庫群組6 = 6,
            倉庫群組7 = 7,
            倉庫群組8 = 8,
            倉庫群組9 = 9,
            倉庫群組10 = 10
        }

        public enum ShopGroup : int
        {
            未分類群組 = 0,
            店點群組1 = 1,
            店點群組2 = 2,
            店點群組3 = 3,
            店點群組4 = 4,
            店點群組5 = 5,
            店點群組6 = 6,
            店點群組7 = 7,
            店點群組8 = 8,
            店點群組9 = 9,
            店點群組10 = 10
        }

        public enum ReceiptKind : int
        {
            免用統一發票 = 0,
            二聯式發票 = 1,
            三聯式發票 = 2,
            收銀機統一發票 = 3,
            電子發票 = 4
        }

        public enum Gender : int
        {
            男 = 1,
            女 = 2
        }

        public enum FunctionGroup : int
        {
            Admin = 0,
            後台 = 1,
            前台 = 2,
            分析 = 3,
            維修 = 4
        }
    }
}
