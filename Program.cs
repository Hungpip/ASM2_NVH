namespace ASM2_NVH {

	internal static class Program {
		[STAThread]
		private static void Main() {
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}