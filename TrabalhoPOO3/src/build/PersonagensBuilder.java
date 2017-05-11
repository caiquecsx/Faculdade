package build;

public abstract class PersonagensBuilder {
	public Personagens personagen = new Personagens();
	abstract void buildNome();
	abstract void buildClasse();
	abstract void buildEquips();
	public Personagens getPersonagen(){
		return personagen;
	}
}