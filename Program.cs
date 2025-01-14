using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;

class DigitalSignatureWithCertificate
{
	static async Task Main()
	{
		var items = new List<string>([
			"https://phunugioi.com/wp-content/uploads/2020/04/hinh-anh-con-cho-de-thuong-cute-nhat-the-gioi.jpg",
			"https://tse2.mm.bing.net/th?id=OIP.ImsQXvGCAeiKP3su5D4w0AHaGK&pid=Api&P=0&w=300&h=300",
			"https://toigingiuvedep.vn/wp-content/uploads/2022/06/anh-cho-shiba.jpg",
			"https://khoinguonsangtao.vn/wp-content/uploads/2022/12/hinh-anh-cho-nhe-rang.jpg",
			"https://khoinguonsangtao.vn/wp-content/uploads/2022/10/hinh-anh-con-cho-con-de-thuong.jpg",
			"https://qpet.vn/wp-content/uploads/2023/04/hinh-anh-cho-shiba-cuoi-hai-huoc_011111806.jpg",
			"https://thuthuatnhanh.com/wp-content/uploads/2022/06/Hinh-cho-cute-Anime.jpg",
			"https://img2.thuthuatphanmem.vn/uploads/2019/03/09/anh-cho-den-dep-nhat_114213129.jpg",
			"https://tse2.mm.bing.net/th?id=OIP.ImsQXvGCAeiKP3su5D4w0AHaGK&pid=Api&H=132&W=160",
			"https://chocanh.vn/wp-content/uploads/anh-cho-cute-chibi_101012640.png"
		]);

		int i = 1;
		using var httpClient = new HttpClient();

		foreach (var item in items)
		{
			var imageBytes = await httpClient.GetByteArrayAsync(item);

			string outputPath = $"./ThuMucRa/out-{i++}.webp";

			using (Image image = Image.Load(imageBytes))
			{
				var pngEncoder = new WebpEncoder()
				{
					Quality = 50, // Nén tốt nhất mà không giảm chất lượng
				};
				image.Save(outputPath, pngEncoder);
			}
		}
	}
}

