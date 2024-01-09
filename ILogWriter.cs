namespace DynamicProg;

public interface ILogWriter
{
	TextWriter GetWriter();
	void EndMessage();
}
