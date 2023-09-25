using Microsoft.AspNetCore.Components;

namespace datalistSample.Client.Pages
{
    public partial class View
    {
        private int? Code { get; set; }
        private List<ViewData> Views { get; set; }

        private int? ViewCode { get; set; }

        protected override void OnInitialized()
        {
            Views = new List<ViewData>()
            {
                new ViewData()
                {
                   Code = 0,
                   Name = "りんご",
                },
                new ViewData()
                {
                   Code = 1,
                   Name = "ごりら",
                },
                new ViewData()
                {
                   Code = 2,
                   Name = "らっぱ",
                },
                new ViewData()
                {
                   Code = 3,
                   Name = "パソコン",
                }
            };
        }

        private void ChangeSelect(ChangeEventArgs e)
        {
            if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
            {
                // 一致するコードを取得
                var selectCode = Views.FirstOrDefault(x => x.Name.Equals(e.Value));
                // データに格納
                Code = selectCode != null ? selectCode.Code : null;

                ViewCode = Code;
            }
        }
    }

    public class ViewData
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
