package build;

public class CriadorDePersonagens {
	public PersonagensBuilder criador;
	
	CriadorDePersonagens(PersonagensBuilder criador){
		this.criador = criador;
	}
	
	public void criarPersonagem(){
		criador.buildNome();
		criador.buildClasse();
		criador.buildEquips();
	}
	
	public Personagens getPersonagen(){
		return criador.getPersonagen();
	}
}
