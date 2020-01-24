using System;
using Extra_task_1.Droid;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Extra_task_1;
using Android.Graphics;
using Android.Content;

[assembly: ExportRenderer(typeof(GradientColorStack), typeof(GradientColorStackRenderer))]
namespace Extra_task_1 {
    [Obsolete]
    public class GradientColorStackRenderer : VisualElementRenderer<StackLayout>
    {
        public GradientColorStackRenderer(Context context) : base(context) { }
        private Xamarin.Forms.Color StartColor { get; set; }
        private Xamarin.Forms.Color EndColor { get; set; }
        protected override void DispatchDraw(Canvas canvas)
        {
           
            var gradient = new LinearGradient(0, 0, Width, 0, StartColor.ToAndroid(), EndColor.ToAndroid(), Shader.TileMode.Mirror);

            var paint = new Paint();
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }
        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);

            var stack = e.NewElement as GradientColorStack;
            this.StartColor = stack.StartColor;
            this.EndColor = stack.EndColor;
        }
    }
}
  