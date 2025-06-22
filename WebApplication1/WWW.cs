namespace WebApplication1
{
    public class WWW
    {
        public string? NAME { get; set; }

        public int? LOCK_VERSION { get; set; }

        /// <summary>
        /// 不重複流水號
        /// </summary>
        public string GID { get; set; } = null!;

        public decimal NUMGID { get; set; }
    }
}
