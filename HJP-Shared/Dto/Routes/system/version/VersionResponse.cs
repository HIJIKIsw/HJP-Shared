namespace Hjp.Shared.Dto.System.Version
{
    public class VersionResponse
    {
        /// <summary>
        /// メジャーバージョン
        /// </summary>
        /// <remarks>
        /// API構造が根本的に変わるなど、大規模なアップデート時にインクリメントされる。
        /// このバージョンが一致する限り、破壊的変更は行われない。
        /// </remarks>
        public required int Major { get; set; }
        /// <summary>
        /// マイナーバージョン
        /// </summary>
        /// <remarks>
        /// 主にAPI追加時など、破壊的変更でないアップデート時にインクリメントされる。
        /// </remarks>
        public required int Minor { get; set; }
        /// <summary>
        /// パッチバージョン
        /// </summary>
        /// <remarks>
        /// 主にバグ修正やレスポンスプロパティ追加など、軽微なアップデート時にインクリメントされる。
        /// </remarks>
        public required int Patch { get; set; }
    }
}